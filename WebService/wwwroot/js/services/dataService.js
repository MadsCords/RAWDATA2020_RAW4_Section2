define([], () => {

    let getTitles = (callback) =>
    {
        fetch('api/Titles')
            .then(response => response.json())
            .then(callback);
    } 

    let getTitle = (tconst, callback) => {
        fetch('api/Title/' + tconst)
            .then(response => response.json())
            .then(callback);
    }
    return {
        getTitles,
        getTitle
    }
});