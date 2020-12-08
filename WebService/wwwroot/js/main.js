
require.config({
    baseUrl: "js",
    paths: {
        knockout: "lib/knockout/knockout-latest.debug",
        text: "lib/require-text/text.min",
        dataservice: "services/dataService",
        bootstrap: "../css/lib/twitter-bootstrap/js/bootstrap.bundle.min",
        jquery: "lib/jquery/jquery.min",
        postman: "services/postman"
    },
    shim: {
        bootstrap: ['jquery']
    }
});

require(['knockout', 'text'], (ko) => {
    ko.components.register('movies', {
        viewModel: { require: "components/movies/movies" },
        template: { require: "text!components/movies/movies.html"}
    });
    
    ko.components.register('home', {
        viewModel: { require: "components/home/home" },
        template: { require: "text!components/home/home.html" }
    });

});

require(['knockout', 'viewModel', 'bootstrap'], (ko, vm) => {
    ko.applyBindings(vm);
});