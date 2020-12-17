define(['knockout',], (ko) => {
    let currentComponent = ko.observable("home");
    let menuElements = ko.observableArray(["Home", "Movies", "Actors", 'Login', 'Signup']);
    let titles = ko.observableArray();
    let user = ko.observable();
    let changeContent = element => {
        console.log(element);
        currentComponent(element.toLowerCase());

    }


    let isActive = element => {
        return element.toLowerCase() === currentComponent() ? "active" : ""


    }

    user.subscribe(() => {
        if (user() !== undefined) {
            menuElements.splice(3);
            menuElements.push('MyProfile', 'Logout');
        }
       
    });

    return {
        currentComponent,    
        menuElements,
        changeContent,
        isActive,
        titles,
        user

    };


});