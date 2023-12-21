import {
    CustomerAddEditCustomControlBase,
    ICustomerAddEditCustomControlState,
    ICustomerAddEditCustomControlContext,
    CustomerAddEditCustomerUpdatedData
} from "PosApi/Extend/Views/CustomerAddEditView";
import { ObjectExtensions } from "PosApi/TypeExtensions";
import { ProxyEntities } from "PosApi/Entities";
import LATCODocumentTypeViewModel from "./LATCODocumentTypeViewModel";

import ko from "knockout";

interface ILATCODocumentType {
    DocumentId: string;
    Description: string;
}

export default class CustomerFields extends CustomerAddEditCustomControlBase {
    private static readonly TEMPLATE_ID: string = "Microsoft_Pos_Extensibility_Samples_CustomerFields";
    public accountNumber: ko.Observable<string>;

    public readonly latcoDocumentTypeViewModel: LATCODocumentTypeViewModel;


    public IDENTIFICATIONNUMBER: ko.Observable<string>
    public LATCODocumentType: ko.Observable<string>
    public LATCOContributorType: ko.Observable<string>
    public LATCOActivityCIIUId: ko.Observable<string>
    public LATCOIvaRegime: ko.Observable<string>
    public LATCOObligationCode: ko.Observable<string>
    public customerIsPerson: ko.Observable<boolean>;
    //public LATCODocumentTypeList: ko.Observable<ILATCODocumentType> = [] ;
    //public LATCODocumentTypeList: ko.Observable<Entities.LATCOBasicDocumentTypeEntity>[] = [];
    public LATCODocumentTypeList: ILATCODocumentType[] = [];
    
    constructor(id: string, context: ICustomerAddEditCustomControlContext) {
        super(id, context);

        // Initialize the view model.
        this.latcoDocumentTypeViewModel = new LATCODocumentTypeViewModel(context);

        this.accountNumber = ko.observable("");
        this.customerIsPerson = ko.observable(true);

        let IDENTIFICATIONNUMBER_key: string = "IDENTIFICATIONNUMBER";
        let LATCODocumentType_key: string = "LATCODOCUMENTTYPE";
        let LATCOContributorType_key: string = "LATCOCONTRIBUTORTYPE";
        let LATCOActivityCIIUId_key: string = "LATCOACTIVITYCIIUID";
        let LATCOIvaRegime_key: string = "LATCOIVAREGIME";
        let LATCOObligationCode_key: string = "LATCOOBLIGATIONCODE";

        this.customerUpdatedHandler = (data: CustomerAddEditCustomerUpdatedData) => {
            this.customerIsPerson(data.customer.CustomerTypeValue === ProxyEntities.CustomerType.Person);
        };

        this.IDENTIFICATIONNUMBER = ko.observable("");
        this.IDENTIFICATIONNUMBER.subscribe((newValue: string): void => {
            this._addOrUpdateExtensionProperty(IDENTIFICATIONNUMBER_key, <ProxyEntities.CommercePropertyValue>{ StringValue: newValue });
        });

        this.LATCODocumentType = ko.observable("");
        this.LATCODocumentType.subscribe((newValue: string): void => {
            this._addOrUpdateExtensionProperty(LATCODocumentType_key, <ProxyEntities.CommercePropertyValue>{ StringValue: newValue });
        });

        this.LATCOContributorType = ko.observable("");
        this.LATCOContributorType.subscribe((newValue: string): void => {
            this._addOrUpdateExtensionProperty(LATCOContributorType_key, <ProxyEntities.CommercePropertyValue>{ StringValue: newValue });
        });

        this.LATCOActivityCIIUId = ko.observable("");
        this.LATCOActivityCIIUId.subscribe((newValue: string): void => {
            this._addOrUpdateExtensionProperty(LATCOActivityCIIUId_key, <ProxyEntities.CommercePropertyValue>{ StringValue: newValue });
        });

        this.LATCOIvaRegime = ko.observable("");
        this.LATCOIvaRegime.subscribe((newValue: string): void => {
            this._addOrUpdateExtensionProperty(LATCOIvaRegime_key, <ProxyEntities.CommercePropertyValue>{ StringValue: newValue });
        });

        this.LATCOObligationCode = ko.observable("");
        this.LATCOObligationCode.subscribe((newValue: string): void => {
            this._addOrUpdateExtensionProperty(LATCOObligationCode_key, <ProxyEntities.CommercePropertyValue>{ StringValue: newValue });
        });

        if (this.customerIsPerson() === true) {
            //alert('verdadero');
            this.LATCODocumentType = ko.observable("CC")
            //this._addOrUpdateExtensionProperty(LATCODocumentType_key, <ProxyEntities.CommercePropertyValue>{ StringValue: newValue });
        } else {
            //alert('falso');
            this.LATCODocumentType = ko.observable("NIT")
        }

        //this.LATCODocumentTypeList = [{ DocumentId: "CC", Description: "Ced. Ciudadania" }, { DocumentId: "NIT", Description: "Nro. Ident. Tributario" }];

        this.latcoDocumentTypeViewModel.load()
            .then((): void => {
                //this.LATCODocumentTypeList = this.latcoDocumentTypeViewModel.loadedData;
                for (var i = 0; i < this.latcoDocumentTypeViewModel.loadedData.length; i++) {
                    this.LATCODocumentTypeList.push({ DocumentId: this.latcoDocumentTypeViewModel.loadedData[i].DocumentId, Description: this.latcoDocumentTypeViewModel.loadedData[i].Description });
                }
            })
            .catch((reason: any) => {
                alert(`Error en constructor CustomerFields: this.latcoDocumentTypeViewModel.load(): ${JSON.stringify(reason)}`);
                this.context.logger.logError("An error occurred while loading the LATCOBasicDocumentTypeViewModel: " + JSON.stringify(reason));
            });

        // Logs the completion of constructing the DualDisplayCustomControl.
        this.context.logger.logInformational("Samples_CustomerFields constructed", this.context.logger.getNewCorrelationId());
    }

    /**
     * Binds the control to the specified element.
     * @param {HTMLElement} element The element to which the control should be bound.
     */
    public onReady(element: HTMLElement): void {
        ko.applyBindingsToNode(element, {
            template: {
                name: CustomerFields.TEMPLATE_ID,
                data: this
            }
        });

       /*document.getElementById("customerTypeInput").addEventListener('change', () => {
            if (this.customerIsPerson() === true) {
                document.getElementById("LATCODocumentType").innerHTML = "CC"
                this.LATCODocumentType = ko.observable("CC")
                this._addOrUpdateExtensionProperty("LATCODOCUMENTTYPE", <ProxyEntities.CommercePropertyValue>{ StringValue: "CC" });
                //alert('verdadero');
            } else {
                document.getElementById("LATCODocumentType").innerHTML = "NIT"
                this.LATCODocumentType = ko.observable("NIT")
                this._addOrUpdateExtensionProperty("LATCODOCUMENTTYPE", <ProxyEntities.CommercePropertyValue>{ StringValue: "NIT" });
                //alert('falso');
            }
        });*/
    }

    /**
   * Initializes the control.
   * @param {ICustomerDetailCustomControlState} state The initial state of the page used to initialize the control.
   */
    public init(state: ICustomerAddEditCustomControlState): void {

        if (!state.isSelectionMode) {

            this.isVisible = true;

            this.customerIsPerson(state.customer.CustomerTypeValue === ProxyEntities.CustomerType.Person);
            this.accountNumber(state.customer.AccountNumber);
            this.IDENTIFICATIONNUMBER(state.customer.IdentificationNumber);

            let LATCODocumentTypeKey: string = "LATCODOCUMENTTYPE";
            let LATCOContributorTypeKey: string = "LATCOCONTRIBUTORTYPE";
            let LATCOActivityCIIUIdKey: string = "LATCOACTIVITYCIIUID";
            let LATCOIvaRegimeKey: string = "LATCOIVAREGIME";
            let LATCOObligationCodeKey: string = "LATCOOBLIGATIONCODE";
            let LATCODocumentTypeExtensionValue: ProxyEntities.CommercePropertyValue = undefined;
            let LATCOContributorTypeExtensionValue: ProxyEntities.CommercePropertyValue = undefined;
            let LATCOActivityCIIUIdExtensionValue: ProxyEntities.CommercePropertyValue = undefined;
            let LATCOIvaRegimeExtensionValue: ProxyEntities.CommercePropertyValue = undefined;
            let LATCOObligationCodeExtensionValue: ProxyEntities.CommercePropertyValue = undefined;
            let LATCODocumentTypeExtensionProperty: ProxyEntities.CommerceProperty =
                Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, (property: ProxyEntities.CommerceProperty) => {
                    return property.Key === LATCODocumentTypeKey;
                });
            let LATCOContributorTypeExtensionProperty: ProxyEntities.CommerceProperty =
                Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, (property: ProxyEntities.CommerceProperty) => {
                    return property.Key === LATCOContributorTypeKey;
                });
            let LATCOActivityCIIUIdExtensionProperty: ProxyEntities.CommerceProperty =
                Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, (property: ProxyEntities.CommerceProperty) => {
                    return property.Key === LATCOActivityCIIUIdKey;
                });
            let LATCOIvaRegimeExtensionProperty: ProxyEntities.CommerceProperty =
                Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, (property: ProxyEntities.CommerceProperty) => {
                    return property.Key === LATCOIvaRegimeKey;
                });
            let LATCOObligationCodeExtensionProperty: ProxyEntities.CommerceProperty =
                Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, (property: ProxyEntities.CommerceProperty) => {
                    return property.Key === LATCOObligationCodeKey;
                });

            if (!ObjectExtensions.isNullOrUndefined(LATCODocumentTypeExtensionProperty)) {
                LATCODocumentTypeExtensionValue = LATCODocumentTypeExtensionProperty.Value;
                this.LATCODocumentType(LATCODocumentTypeExtensionValue.StringValue);
            }
            if (!ObjectExtensions.isNullOrUndefined(LATCOContributorTypeExtensionProperty)) {
                LATCOContributorTypeExtensionValue = LATCOContributorTypeExtensionProperty.Value;
                this.LATCOContributorType(LATCOContributorTypeExtensionValue.StringValue);
            }
            if (!ObjectExtensions.isNullOrUndefined(LATCOActivityCIIUIdExtensionProperty)) {
                LATCOActivityCIIUIdExtensionValue = LATCOActivityCIIUIdExtensionProperty.Value;
                this.LATCOActivityCIIUId(LATCOActivityCIIUIdExtensionValue.StringValue);
            }
            if (!ObjectExtensions.isNullOrUndefined(LATCOIvaRegimeExtensionProperty)) {
                LATCOIvaRegimeExtensionValue = LATCOIvaRegimeExtensionProperty.Value;
                this.LATCOIvaRegime(LATCOIvaRegimeExtensionValue.StringValue);
            }
            if (!ObjectExtensions.isNullOrUndefined(LATCOObligationCodeExtensionProperty)) {
                LATCOObligationCodeExtensionValue = LATCOObligationCodeExtensionProperty.Value;
                this.LATCOObligationCode(LATCOObligationCodeExtensionValue.StringValue);
            }

            

            /*if (this.customerIsPerson() === true) {
                this.LATCODocumentType = ko.observable("CC");
            } else {
                this.LATCODocumentType = ko.observable("NIT");
            }*/
        }
    }

    private _addOrUpdateExtensionProperty(key: string, newValue: ProxyEntities.CommercePropertyValue): void {
        //alert(`Desde _addOrUpdateExtensionProperty: newValue: ${newValue}   ${this.customerIsPerson()}`);
        let customer: ProxyEntities.Customer = this.customer;
        if (ObjectExtensions.isNullOrUndefined(customer))
            return;

        if (ObjectExtensions.isNullOrUndefined(customer.ExtensionProperties)) {
            customer.ExtensionProperties = [];
        }

        let extensionProperty: ProxyEntities.CommerceProperty =
            Commerce.ArrayExtensions.firstOrUndefined(customer.ExtensionProperties, (property: ProxyEntities.CommerceProperty) => {
                return property.Key === key;
            });

        if (ObjectExtensions.isNullOrUndefined(extensionProperty)) {
            let newProperty: ProxyEntities.CommerceProperty = {
                Key: key,
                Value: newValue
            };

            if (ObjectExtensions.isNullOrUndefined(customer.ExtensionProperties)) {
                customer.ExtensionProperties = [];
            }

            customer.ExtensionProperties.push(newProperty);
        } else {
            extensionProperty.Value = newValue;
        }

        this.customer = customer;
    }
}