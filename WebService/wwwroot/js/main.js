C: \Users\madsc\Source\Repos\RAWDATA_2020_LiveCode5\WebService\wwwroot\css\lib\twitter - bootstrap]\
require.config({
    baseUrl: "js",
    paths: {
        knockout: "lib/knockout/knockout-latest.debug",
        text: "lib/require-text/text.min",
        dataservice: "services/dataService",
        bootstrap: "css/lib/twitter-bootstrap/js/bootstrap.bundle.min",
        jqeury: "lib/jquery/jquery.min"
    },
    shim: {
        bootstrap: ['jquery']
    }
});

require(['knockout', 'viewmodel', 'bootstrap'], (ko,vm) => {
    ko.applyBindings(vm);
});