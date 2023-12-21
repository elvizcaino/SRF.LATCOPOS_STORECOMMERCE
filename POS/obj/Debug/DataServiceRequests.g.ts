
/* tslint:disable */
import { ProxyEntities } from "PosApi/Entities";

import { Entities } from "./DataServiceEntities.g";

import { DataServiceRequest, DataServiceResponse } from "PosApi/Consume/DataService";
export { ProxyEntities };

export { Entities };

export namespace LATCOBasicDocumentTypeController {
  // Entity Set LATCOBasicDocumentTypeEntity
  export class GetAllLATCOBasicDocumentTypeResponse extends DataServiceResponse {
    public result: Entities.LATCOBasicDocumentTypeEntity[];
  }

  export class GetAllLATCOBasicDocumentTypeRequest<TResponse extends GetAllLATCOBasicDocumentTypeResponse> extends DataServiceRequest<TResponse> {
    /**
     * Constructor
     */
      public constructor() {
        super();

        this._entitySet = "LATCOBasicDocumentTypeController";
        this._entityType = "LATCOBasicDocumentTypeEntity";
        this._method = "GetAllLATCOBasicDocumentType";
        this._parameters = {  };
        this._isAction = false;
        this._returnType = Entities.LATCOBasicDocumentTypeEntity;
        this._isReturnTypeCollection = true;
        
      }
  }

}
