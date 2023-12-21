import { IExtensionViewControllerContext } from "PosApi/Create/Views";
import { Entities } from "../../DataService/DataServiceEntities.g";
import * as Messages from "../../DataService/DataServiceRequests.g";

/**
 * Represents the LATCOBasicDocumentTypeViewModel class.
 */

export default class LATCODocumentTypeViewModel {
    public loadedData: Entities.LATCOBasicDocumentTypeEntity[];
    private _context: IExtensionViewControllerContext;

    constructor(context: IExtensionViewControllerContext) {
        this._context = context;
        this.loadedData = [];
    }

    public load(): Promise<void> {
        /*this.loadedData = [
            {
                DocumentId: "CC", Description: "Cédula de Ciudadanía", UnusualEntityId: 1, ExtensionProperties: null
            },
            {
                DocumentId: "NIT", Description: "Nro Id Tributario", UnusualEntityId: 2, ExtensionProperties: null
            }
        ];

        return Promise.resolve();*/


        return this._context.runtime
            .executeAsync(new Messages.LATCOBasicDocumentTypeController.GetAllLATCOBasicDocumentTypeRequest())
            .then(response => {
                if (!response.canceled) {
                    this.loadedData = response.data.result;
                }
            })
            .catch(reason => {
                alert(`Error en load(): ${JSON.stringify(reason)}`);
                this._context.logger.logError("An unexpected error occurred: " + JSON.stringify(reason));
            });
    }
};