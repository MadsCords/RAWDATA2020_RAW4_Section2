define(['knockout','dataservice','viewModel'], (ko, ds, vm) => {
    return function (params) {
        vm.user(undefined);
        let username = ko.observable();
        let password = ko.observable();

        let checkUsername = () => {
           
            ds.verifyUser(username(), password(), user => {
                if (user !== undefined) {
                    vm.user(user);
                    alert('You have succesfully logged in!');
                    vm.changeContent("Home");
                   
                }
                else {
                    alert('Username or password is incorrect.');
                    username('');
                    password('');
                }
            });

        };

        return {
            username,
            password,
            checkUsername
            
        };

    }

});