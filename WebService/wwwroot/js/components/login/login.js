define(['knockout','dataservice','viewModel'], (ko, ds, vm) => {
    return function (params) {
        vm.loggedIn(false);
        let username = ko.observable();
        let password = ko.observable();
        

        let checkUsername = () => {
            //console.log(username);
            ds.verifyUser(username(), status => {
                if (status === true) {
                    vm.loggedIn(true);
                    alert('You have succesfully logged in!');
                    vm.changeContent("Home");
                }
                else {
                    alert('Username or password is incorrect.');
                    vm.loggedIn(false);

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