define(['knockout','viewModel','dataservice'], (ko, vm, ds) => {
    return function (params) {
        //debugger;
        let movieTitles = ko.observableArray([]);
        let searchTitle = ko.observableArray([]);
        let selectedMovie = ko.observable();
        let userid = 1;
        let searchstring = ko.observable('hej');
        let selectMovie = movieTitle => {
            console.log(movieTitle);
            selectedMovie(movieTitle);

            
        }
        let doSearch = () => {
              ds.searchTitle(userid, searchstring(), function (data) { searchTitle(data) });

        };

        vm.getTitles(function (data) { movieTitles(data) });
        return {
            movieTitles,
            selectedMovie,
            selectMovie,
            searchTitle,
            searchstring,
            doSearch
        };
    }
});