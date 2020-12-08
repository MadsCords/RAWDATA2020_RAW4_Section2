define(['knockout','viewModel'], (ko, vm) => {
    return function (params) {
        //debugger;
        let movieTitles = ko.observableArray([]);
        let selectedMovie = ko.observable();
        let selectMovie = movieTitle => {
            console.log(movieTitle);
            selectedMovie(movieTitle);

            
        }



        vm.getTitles(function (data) { movieTitles(data) });
        return {
            movieTitles,
            selectedMovie,
            selectMovie
        };
    }
});