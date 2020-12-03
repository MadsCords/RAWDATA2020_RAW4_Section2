
require.config({
    baseUrl: "js",
    paths: {
        knockout: "lib/knockout/knockout-latest.debug",
        text: "lib/require-text/text.min",
        dataservice: "services/dataService",
        bootstrap: "../css/lib/twitter-bootstrap/js/bootstrap.bundle.min",
        jquery: "lib/jquery/jquery.min"
    },
    shim: {
        bootstrap: ['jquery']
    }
});

require(['knockout', 'viewmodel', 'bootstrap'], (ko,vm) => {
    ko.applyBindings(vm);
});