define(['knockout', 'dataservice','viewModel'], (ko, ds, vm) => {
    return function (params) {

        let username = ko.observable();
        let password = ko.observable();
        let firstName = ko.observable();
        let lastName = ko.observable();
        let birthyear = ko.observable();

        let createUser = () => {
            let user = {
                username: username(),
                password: password(),
                firstName: firstName(),
                lastname: lastName(),
                birthyear: birthyear()
            };
            ds.createUser(user, (newUser) => {
                if (newUser == undefined) {
                    alert('User not valid');
                    username('');
                    password('');
                    firstName('');
                    lastName('');
                    birthyear('');
                }
                else {
                    alert('You have succesfully signed in!')
                    vm.changeContent("login");

                }
            });
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