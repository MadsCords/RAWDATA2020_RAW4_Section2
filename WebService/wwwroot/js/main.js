
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

    ko.components.register('actors', {
        viewModel: { require: "components/actors/actors" },
        template: { require: "text!components/actors/actors.html" }
    });

    ko.components.register('signup', {
        viewModel: { require: "components/signup/signup" },
        template: { require: "text!components/signup/signup.html" }
    });

    ko.components.register('login', {
        viewModel: { require: "components/login/login" },
        template: { require: "text!components/login/login.html" }
    });

    ko.components.register('myprofile', {
        viewModel: { require: "components/myprofile/myprofile" },
        template: { require: "text!components/myprofile/myprofile.html" }
    });

});

require(['knockout', 'viewModel', 'bootstrap'], (ko, vm) => {
    ko.applyBindings(vm);
});