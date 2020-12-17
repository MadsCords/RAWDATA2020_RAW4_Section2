define(['knockout','viewModel','dataservice'], (ko, vm, ds) => {
    return function (params) {
 
        let movieTitles = ko.observableArray([]);
        let searchTitle = ko.observableArray([]);
        let prev = ko.observable();
        let next = ko.observable();
        let pageSizes = ko.observableArray();
        let selectedPageSize = ko.observableArray([10]);
        let searchstring = ko.observable();

        let selectedMovie = ko.observable();
        let selectMovie = movieTitle => {
            console.log(movieTitle);
            selectedMovie(movieTitle);
        }

        let getData = url => {
            ds.getTitles(url, data => {
                pageSizes(data.pageSizes);
                prev(data.prev || undefined);
                next(data.next || undefined);
                movieTitles(data.items)
            });
        }
        getData();

        let showPrev = movieTitles => {
            console.log(prev());
            getData(prev());
        }

        let enablePrev = ko.computed(() => prev() !== undefined);

        let showNext = movieTitles => {
            console.log(next());
            getData(next());
        }  

        let enableNext = ko.computed(() => next() !== undefined);

        selectedPageSize.subscribe(() => {
            var size = selectedPageSize()[0];
            getData(ds.getTitlesUrlWithPagesSize(size));
        });

        let doSearch = () => {
            ds.searchTitle(vm.user().userid, searchstring(), function (data) { searchTitle(data) });
        };

        return {
            movieTitles,
            selectedMovie,
            selectMovie,
            searchTitle,
            searchstring,
            doSearch,
            showPrev,
            showNext,
            enablePrev,
            enableNext,
            pageSizes,
            selectedPageSize

        };
    }
});