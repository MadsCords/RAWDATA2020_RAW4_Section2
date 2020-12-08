define(['knockout','viewModel','dataService'], (ko, vm, ds) => {
    return function (params) {
        //debugger;
       // let movieTitles = ko.observableArray([]);
        let searchTitle = ko.observableArray([]);
        let selectedMovie = ko.observable();
        let selectMovie = movieTitle => {
            console.log(movieTitle);
            selectedMovie(movieTitle);

            
        }

        ds.searchTitle(userid + searchstring, function (data) { searchTitle });

        //vm.getTitles(function (data) { movieTitles(data) });
        return {
            //movieTitles,
            selectedMovie,
            selectMovie
        };
    }
});