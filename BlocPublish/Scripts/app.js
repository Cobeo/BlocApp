var ViewModel = function () {
    var self = this;
    self.blocs = ko.observableArray();
    self.error = ko.observable();

    var blocsUri = '/api/blocs/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllBlocs() {
        ajaxHelper(blocsUri, 'GET').done(function (data) {
            self.blocs(data);
        });
    }

    self.detail = ko.observable();

    self.getBlocDetail = function (item) {
        ajaxHelper(blocsUri + item.Id, 'GET').done(function (data) {
            self.detail(data);
        });
    }

    // Fetch the initial data.
    getAllBlocs();

    self.cotations = ko.observableArray();
    self.newBloc = {
        Cotation: ko.observable(),
        AcheivedDate: ko.observable(),
        Location: ko.observable(),
        NumberDone: ko.observable(),
        NumberFlashed: ko.observable()
    }

    var cotationsUri = '/api/cotations/';

    function getCotations() {
        ajaxHelper(cotationsUri, 'GET').done(function (data) {
            self.cotations(data);
        });
    }

    self.addBloc = function (formElement) {
        var bloc = {
            CotationId: self.newBloc.Cotation().Id,
            AcheivedDate: self.newBloc.AcheivedDate(),
            Location: self.newBloc.Location(),
            NumberDone: self.newBloc.NumberDone(),
            NumberFlashed: self.newBloc.NumberFlashed()
        };

        ajaxHelper(blocsUri, 'POST', bloc).done(function (item) {
            self.blocs.push(item);
        });
    }

    getCotations();
};

ko.applyBindings(new ViewModel());