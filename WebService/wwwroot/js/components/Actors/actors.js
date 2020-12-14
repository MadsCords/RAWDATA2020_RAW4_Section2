define(['knockout','dataservice'], (ko, ds) => {
    return function (params) {
        let actors = ko.observableArray([]);
        let prev = ko.observable();
        let next = ko.observable();
        let pageSizes = ko.observableArray();
        let selectedPageSize = ko.observableArray([10]);

        let searchActor = ko.observableArray([]);
        let searchstring = ko.observable();

        let doSearch = () => {
            ds.searchActor(searchstring(), function (data) {
                searchActor(data)
            });
        };

        let getData = url => {
            ds.getActors(url, data => {
                pageSizes(data.pageSizes);
                prev(data.prev || undefined);
                next(data.next || undefined);
                actors(data.items)
            });
        }

        let showPrev = actors => {
            console.log(prev());
            getData(prev());
        }

        let enablePrev = ko.computed(() => prev() !== undefined);

        let showNext = actors => {
            console.log(next());
            getData(next());
        }  

        let enableNext = ko.computed(() => next() !== undefined);

        selectedPageSize.subscribe(() => {
            var size = selectedPageSize()[0];
            getData(ds.getActorsUrlWithPagesSize(size));
        });

        getData();

        return {
            actors,
            searchActor,
            searchstring,
            doSearch,
            getData,
            pageSizes,
            selectedPageSize,
            showPrev,
            showNext,
            enablePrev,
            enableNext
        };
    };
});