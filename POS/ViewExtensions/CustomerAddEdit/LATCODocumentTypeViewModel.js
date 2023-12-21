System.register(["../../DataService/DataServiceRequests.g"], function (exports_1, context_1) {
    "use strict";
    var Messages, LATCODocumentTypeViewModel;
    var __moduleName = context_1 && context_1.id;
    return {
        setters: [
            function (Messages_1) {
                Messages = Messages_1;
            }
        ],
        execute: function () {
            LATCODocumentTypeViewModel = (function () {
                function LATCODocumentTypeViewModel(context) {
                    this._context = context;
                    this.loadedData = [];
                }
                LATCODocumentTypeViewModel.prototype.load = function () {
                    var _this = this;
                    return this._context.runtime
                        .executeAsync(new Messages.LATCOBasicDocumentTypeController.GetAllLATCOBasicDocumentTypeRequest())
                        .then(function (response) {
                        if (!response.canceled) {
                            _this.loadedData = response.data.result;
                        }
                    })
                        .catch(function (reason) {
                        alert("Error en load(): " + JSON.stringify(reason));
                        _this._context.logger.logError("An unexpected error occurred: " + JSON.stringify(reason));
                    });
                };
                return LATCODocumentTypeViewModel;
            }());
            exports_1("default", LATCODocumentTypeViewModel);
            ;
        }
    };
});
//# sourceMappingURL=C:/DevPOS/LATCOPOS_STORECOMMERCE/POS/ViewExtensions/CustomerAddEdit/LATCODocumentTypeViewModel.js.map