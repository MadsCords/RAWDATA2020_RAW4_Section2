define(['knockout'], (ko) => {
    let currentUsername = ko.observable();
    let searchstring = ko.observable()

    const titlesApiUrl = "api/Titles";
    const actorsApiUrl = "api/Actors";
    const searchHistoryApiUrl = "api/search/searchHistory/" + userid;

    let getJson = (url, callback) => {
        fetch(url).then(response => response.json()).then(callback);
    };

    let getTitles = (url, callback) => {
        if (url == undefined) {
            url = titlesApiUrl;
        }
        getJson(url, callback);
    };

    let getSearchHistory = (url, callback) => {
        if (url == undefined) {
            url = searchHistoryApiUrl;
        }
        getJson(url, callback);
    }

    let verifyUser = (username, userid, callback) => {
        fetch('api/Users/' + username + userid)
            .then(response => callback(response.status === 200));
       
    }

    let createUser = (user, callback) => {
        fetch('api/Users/createuser', {
            method: 'POST', // or 'PUT'
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(user),
        })
            .then(response => {
                if (response.status > 299) {
                    return callback(undefined);
                }
                return response.json();
            })
            .then(data => {
                callback(data);
            })
            .catch((error) => {
                callback(null);
            });
    }

    let getTitlesUrlWithPagesSize = size => titlesApiUrl + "?pageSize=" + size;

    let getActors = (url, callback) => {
        if (url == undefined) {
            url = actorsApiUrl;
        }
        getJson(url, callback);
    };

    let getActorsUrlWithPagesSize = size => actorsApiUrl + "?pageSize=" + size;

    let getTitle = (tconst, callback) => {
        fetch('api/Title/' + tconst)
            .then(response => response.json())
            .then(data => callback(data));
    }

    let searchTitle = (userid, searchstring, callback) => {
        fetch('api/search/' + userid + '/' + searchstring)
            .then(response => response.json())
            .then(callback);
    }

    let searchActor = (searchstring, callback) => {
        fetch('api/search/actor/' + searchstring)
            .then(response => response.json())
            .then(callback);
    }

    return {
        getTitles,
        getActors,
        getTitle,
        currentUsername,
        searchTitle,
        searchActor,
        getTitlesUrlWithPagesSize,
        getActorsUrlWithPagesSize,
        verifyUser,
        createUser,
        getSearchHistory
    }
});