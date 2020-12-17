define(['knockout','dataservice', 'viewModel'], (ko,ds,vm) => {
    return function (params) {

        let userid = vm.user().userid;
        let searchHistory = ko.observableArray();

        let getData =(userid, url) => {
            ds.getSearchHistory(userid, url, data => {
                searchHistory(data);

            });
        }
        getData(userid);
        return {
            searchHistory,
            user: vm.user()

        };
    }
});