define(['knockout'], (ko) => {
    let currentUsername = ko.observable('hej');
    let myHeaders = new Headers();
    let searchstring = ko.observable()
    myHeaders.append('Authorization', currentUsername);
   
    let getTitles = (callback) => {
        fetch('api/Titles', myHeaders)
        
            .then(response => response.json())
            .then(callback);
    } 

    let getTitle = (tconst, callback) => {
        fetch('api/Title/' + tconst)
            .then(response => response.json())
            .then(callback);
    }

    let searchTitle = (userid, searchstring, callback) => {
        fetch('api/Title/' + userid + searchstring)
            .then(response => response.json())
            .then(callback);
    }
    return {
        getTitles,
        getTitle,
        currentUsername,
        searchTitle
    }
});