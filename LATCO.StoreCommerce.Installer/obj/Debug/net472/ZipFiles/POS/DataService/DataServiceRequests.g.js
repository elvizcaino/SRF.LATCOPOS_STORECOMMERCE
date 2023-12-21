System.register(["PosApi/Entities", "./DataServiceEntities.g", "PosApi/Consume/DataService"], function (exports_1, context_1) {
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
    var Entities_1, DataServiceEntities_g_1, DataService_1, LATCOBasicDocumentTypeController;
    var __moduleName = context_1 && context_1.id;
    return {
        setters: [
            function (Entities_1_1) {
                Entities_1 = Entities_1_1;
            },
            function (DataServiceEntities_g_1_1) {
                DataServiceEntities_g_1 = DataServiceEntities_g_1_1;
            },
            function (DataService_1_1) {
                DataService_1 = DataService_1_1;
            }
        ],
        execute: function () {
            exports_1("ProxyEntities", Entities_1.ProxyEntities);
            exports_1("Entities", DataServiceEntities_g_1.Entities);
            (function (LATCOBasicDocumentTypeController) {
                var GetAllLATCOBasicDocumentTypeResponse = (function (_super) {
                    __extends(GetAllLATCOBasicDocumentTypeResponse, _super);
                    function GetAllLATCOBasicDocumentTypeResponse() {
                        return _super !== null && _super.apply(this, arguments) || this;
                    }
                    return GetAllLATCOBasicDocumentTypeResponse;
                }(DataService_1.DataServiceResponse));
                LATCOBasicDocumentTypeController.GetAllLATCOBasicDocumentTypeResponse = GetAllLATCOBasicDocumentTypeResponse;
                var GetAllLATCOBasicDocumentTypeRequest = (function (_super) {
                    __extends(GetAllLATCOBasicDocumentTypeRequest, _super);
                    function GetAllLATCOBasicDocumentTypeRequest() {
                        var _this = _super.call(this) || this;
                        _this._entitySet = "LATCOBasicDocumentTypeController";
                        _this._entityType = "LATCOBasicDocumentTypeEntity";
                        _this._method = "GetAllLATCOBasicDocumentType";
                        _this._parameters = {};
                        _this._isAction = false;
                        _this._returnType = DataServiceEntities_g_1.Entities.LATCOBasicDocumentTypeEntity;
                        _this._isReturnTypeCollection = true;
                        return _this;
                    }
                    return GetAllLATCOBasicDocumentTypeRequest;
                }(DataService_1.DataServiceRequest));
                LATCOBasicDocumentTypeController.GetAllLATCOBasicDocumentTypeRequest = GetAllLATCOBasicDocumentTypeRequest;
            })(LATCOBasicDocumentTypeController || (LATCOBasicDocumentTypeController = {}));
            exports_1("LATCOBasicDocumentTypeController", LATCOBasicDocumentTypeController);
        }
    };
});
//# sourceMappingURL=C:/DevPOS/LATCOPOS_STORECOMMERCE/POS/DataService/DataServiceRequests.g.js.map