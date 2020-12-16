define(['knockout','dataservice'], (ko,ds) => {
    return function (params) {

        let userid = ko.observable();
        let searchEntry = ko.observable();
        let searchDate = ko.observable();




        let getData = url => {
            ds.getSearchHistory(url, data => {
                userid(data.userid);
                searchEntry(data.searchEntry);
                searchDate(data.searchDate);

            });
        }

        return {
            getData

        };
    }
});