System.register(["PosApi/Extend/Views/CustomerAddEditView", "PosApi/TypeExtensions", "PosApi/Entities", "./LATCODocumentTypeViewModel", "knockout"], function (exports_1, context_1) {
    "use strict";
    var __extends = (this && this.__extends) || (function () {
        var extendStatics = function (d, b) {
            extendStatics = Object.setPrototypeOf ||
                ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
                function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
            return extendStatics(d, b);
        };
        return function (d, b) {
            extendStatics(d, b);
            function __() { this.constructor = d; }
            d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
        };
    })();
    var CustomerAddEditView_1, TypeExtensions_1, Entities_1, LATCODocumentTypeViewModel_1, knockout_1, CustomerFields;
    var __moduleName = context_1 && context_1.id;
    return {
        setters: [
            function (CustomerAddEditView_1_1) {
                CustomerAddEditView_1 = CustomerAddEditView_1_1;
            },
            function (TypeExtensions_1_1) {
                TypeExtensions_1 = TypeExtensions_1_1;
            },
            function (Entities_1_1) {
                Entities_1 = Entities_1_1;
            },
            function (LATCODocumentTypeViewModel_1_1) {
                LATCODocumentTypeViewModel_1 = LATCODocumentTypeViewModel_1_1;
            },
            function (knockout_1_1) {
                knockout_1 = knockout_1_1;
            }
        ],
        execute: function () {
            CustomerFields = (function (_super) {
                __extends(CustomerFields, _super);
                function CustomerFields(id, context) {
                    var _this = _super.call(this, id, context) || this;
                    _this.LATCODocumentTypeList = [];
                    _this.latcoDocumentTypeViewModel = new LATCODocumentTypeViewModel_1.default(context);
                    _this.accountNumber = knockout_1.default.observable("");
                    _this.customerIsPerson = knockout_1.default.observable(true);
                    var IDENTIFICATIONNUMBER_key = "IDENTIFICATIONNUMBER";
                    var LATCODocumentType_key = "LATCODOCUMENTTYPE";
                    var LATCOContributorType_key = "LATCOCONTRIBUTORTYPE";
                    var LATCOActivityCIIUId_key = "LATCOACTIVITYCIIUID";
                    var LATCOIvaRegime_key = "LATCOIVAREGIME";
                    var LATCOObligationCode_key = "LATCOOBLIGATIONCODE";
                    _this.customerUpdatedHandler = function (data) {
                        _this.customerIsPerson(data.customer.CustomerTypeValue === Entities_1.ProxyEntities.CustomerType.Person);
                    };
                    _this.IDENTIFICATIONNUMBER = knockout_1.default.observable("");
                    _this.IDENTIFICATIONNUMBER.subscribe(function (newValue) {
                        _this._addOrUpdateExtensionProperty(IDENTIFICATIONNUMBER_key, { StringValue: newValue });
                    });
                    _this.LATCODocumentType = knockout_1.default.observable("");
                    _this.LATCODocumentType.subscribe(function (newValue) {
                        _this._addOrUpdateExtensionProperty(LATCODocumentType_key, { StringValue: newValue });
                    });
                    _this.LATCOContributorType = knockout_1.default.observable("");
                    _this.LATCOContributorType.subscribe(function (newValue) {
                        _this._addOrUpdateExtensionProperty(LATCOContributorType_key, { StringValue: newValue });
                    });
                    _this.LATCOActivityCIIUId = knockout_1.default.observable("");
                    _this.LATCOActivityCIIUId.subscribe(function (newValue) {
                        _this._addOrUpdateExtensionProperty(LATCOActivityCIIUId_key, { StringValue: newValue });
                    });
                    _this.LATCOIvaRegime = knockout_1.default.observable("");
                    _this.LATCOIvaRegime.subscribe(function (newValue) {
                        _this._addOrUpdateExtensionProperty(LATCOIvaRegime_key, { StringValue: newValue });
                    });
                    _this.LATCOObligationCode = knockout_1.default.observable("");
                    _this.LATCOObligationCode.subscribe(function (newValue) {
                        _this._addOrUpdateExtensionProperty(LATCOObligationCode_key, { StringValue: newValue });
                    });
                    if (_this.customerIsPerson() === true) {
                        _this.LATCODocumentType = knockout_1.default.observable("CC");
                    }
                    else {
                        _this.LATCODocumentType = knockout_1.default.observable("NIT");
                    }
                    _this.latcoDocumentTypeViewModel.load()
                        .then(function () {
                        for (var i = 0; i < _this.latcoDocumentTypeViewModel.loadedData.length; i++) {
                            _this.LATCODocumentTypeList.push({ DocumentId: _this.latcoDocumentTypeViewModel.loadedData[i].DocumentId, Description: _this.latcoDocumentTypeViewModel.loadedData[i].Description });
                        }
                    })
                        .catch(function (reason) {
                        alert("Error en constructor CustomerFields: this.latcoDocumentTypeViewModel.load(): " + JSON.stringify(reason));
                        _this.context.logger.logError("An error occurred while loading the LATCOBasicDocumentTypeViewModel: " + JSON.stringify(reason));
                    });
                    _this.context.logger.logInformational("Samples_CustomerFields constructed", _this.context.logger.getNewCorrelationId());
                    return _this;
                }
                CustomerFields.prototype.onReady = function (element) {
                    knockout_1.default.applyBindingsToNode(element, {
                        template: {
                            name: CustomerFields.TEMPLATE_ID,
                            data: this
                        }
                    });
                };
                CustomerFields.prototype.init = function (state) {
                    if (!state.isSelectionMode) {
                        this.isVisible = true;
                        this.customerIsPerson(state.customer.CustomerTypeValue === Entities_1.ProxyEntities.CustomerType.Person);
                        this.accountNumber(state.customer.AccountNumber);
                        this.IDENTIFICATIONNUMBER(state.customer.IdentificationNumber);
                        var LATCODocumentTypeKey_1 = "LATCODOCUMENTTYPE";
                        var LATCOContributorTypeKey_1 = "LATCOCONTRIBUTORTYPE";
                        var LATCOActivityCIIUIdKey_1 = "LATCOACTIVITYCIIUID";
                        var LATCOIvaRegimeKey_1 = "LATCOIVAREGIME";
                        var LATCOObligationCodeKey_1 = "LATCOOBLIGATIONCODE";
                        var LATCODocumentTypeExtensionValue = undefined;
                        var LATCOContributorTypeExtensionValue = undefined;
                        var LATCOActivityCIIUIdExtensionValue = undefined;
                        var LATCOIvaRegimeExtensionValue = undefined;
                        var LATCOObligationCodeExtensionValue = undefined;
                        var LATCODocumentTypeExtensionProperty = Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, function (property) {
                            return property.Key === LATCODocumentTypeKey_1;
                        });
                        var LATCOContributorTypeExtensionProperty = Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, function (property) {
                            return property.Key === LATCOContributorTypeKey_1;
                        });
                        var LATCOActivityCIIUIdExtensionProperty = Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, function (property) {
                            return property.Key === LATCOActivityCIIUIdKey_1;
                        });
                        var LATCOIvaRegimeExtensionProperty = Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, function (property) {
                            return property.Key === LATCOIvaRegimeKey_1;
                        });
                        var LATCOObligationCodeExtensionProperty = Commerce.ArrayExtensions.firstOrUndefined(this.customer.ExtensionProperties, function (property) {
                            return property.Key === LATCOObligationCodeKey_1;
                        });
                        if (!TypeExtensions_1.ObjectExtensions.isNullOrUndefined(LATCODocumentTypeExtensionProperty)) {
                            LATCODocumentTypeExtensionValue = LATCODocumentTypeExtensionProperty.Value;
                            this.LATCODocumentType(LATCODocumentTypeExtensionValue.StringValue);
                        }
                        if (!TypeExtensions_1.ObjectExtensions.isNullOrUndefined(LATCOContributorTypeExtensionProperty)) {
                            LATCOContributorTypeExtensionValue = LATCOContributorTypeExtensionProperty.Value;
                            this.LATCOContributorType(LATCOContributorTypeExtensionValue.StringValue);
                        }
                        if (!TypeExtensions_1.ObjectExtensions.isNullOrUndefined(LATCOActivityCIIUIdExtensionProperty)) {
                            LATCOActivityCIIUIdExtensionValue = LATCOActivityCIIUIdExtensionProperty.Value;
                            this.LATCOActivityCIIUId(LATCOActivityCIIUIdExtensionValue.StringValue);
                        }
                        if (!TypeExtensions_1.ObjectExtensions.isNullOrUndefined(LATCOIvaRegimeExtensionProperty)) {
                            LATCOIvaRegimeExtensionValue = LATCOIvaRegimeExtensionProperty.Value;
                            this.LATCOIvaRegime(LATCOIvaRegimeExtensionValue.StringValue);
                        }
                        if (!TypeExtensions_1.ObjectExtensions.isNullOrUndefined(LATCOObligationCodeExtensionProperty)) {
                            LATCOObligationCodeExtensionValue = LATCOObligationCodeExtensionProperty.Value;
                            this.LATCOObligationCode(LATCOObligationCodeExtensionValue.StringValue);
                        }
                    }
                };
                CustomerFields.prototype._addOrUpdateExtensionProperty = function (key, newValue) {
                    var customer = this.customer;
                    if (TypeExtensions_1.ObjectExtensions.isNullOrUndefined(customer))
                        return;
                    if (TypeExtensions_1.ObjectExtensions.isNullOrUndefined(customer.ExtensionProperties)) {
                        customer.ExtensionProperties = [];
                    }
                    var extensionProperty = Commerce.ArrayExtensions.firstOrUndefined(customer.ExtensionProperties, function (property) {
                        return property.Key === key;
                    });
                    if (TypeExtensions_1.ObjectExtensions.isNullOrUndefined(extensionProperty)) {
                        var newProperty = {
                            Key: key,
                            Value: newValue
                        };
                        if (TypeExtensions_1.ObjectExtensions.isNullOrUndefined(customer.ExtensionProperties)) {
                            customer.ExtensionProperties = [];
                        }
                        customer.ExtensionProperties.push(newProperty);
                    }
                    else {
                        extensionProperty.Value = newValue;
                    }
                    this.customer = customer;
                };
                CustomerFields.TEMPLATE_ID = "Microsoft_Pos_Extensibility_Samples_CustomerFields";
                return CustomerFields;
            }(CustomerAddEditView_1.CustomerAddEditCustomControlBase));
            exports_1("default", CustomerFields);
        }
    };
});
//# sourceMappingURL=C:/DevPOS/LATCOPOS_STORECOMMERCE/POS/ViewExtensions/CustomerAddEdit/CustomerFields.js.map