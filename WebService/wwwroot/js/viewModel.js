define(['knockout',], (ko) => {
    let loggedIn = ko.observable(false);
    let currentComponent = ko.observable("home");
    let menuElements = ko.observableArray(["Home", "Movies", "Actors", 'Login', 'Signup']);
    let titles = ko.observableArray();
    //let selectedComponent = ko.observable('movies')
    let changeContent = element => {
        console.log(element);
        currentComponent(element.toLowerCase());

    }


    let isActive = element => {
        return element.toLowerCase() === currentComponent() ? "active" : ""


    }

    loggedIn.subscribe(() => {
        if (loggedIn() === true) {
            menuElements.splice(3);
            menuElements.push('MyProfile','Logout');
        }
    });

    //getTitles(x => {
    //    titles(x)
    //});
    
    return {
        currentComponent,    
        menuElements,
        changeContent,
        isActive,
        titles,
        loggedIn
        //selectedComponent

    };


});