define(['knockout'], (ko) => {
    return function (params) {

        let username = ko.observable();
        let password = ko.observable();
        let firstName = ko.observable();
        let lastName = ko.observable();
        let birthyear = ko.observable();

        let createUser = () => {

        };






        return {
            username,
            password,
            firstName,
            lastName,
            birthyear,
            createUser

        };    

    }

});