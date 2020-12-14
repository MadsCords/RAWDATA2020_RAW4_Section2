define(['knockout'], (ko) => {
    let currentComponent = ko.observable("home");
    let menuElements = ["Home", "Movies", "Actors"];
    let titles = ko.observableArray();
    //let selectedComponent = ko.observable('movies')
    let changeContent = element => {
        console.log(element);
        currentComponent(element.toLowerCase());

    }


    let isActive = element => {
        return element.toLowerCase() === currentComponent() ? "active" : ""


    }

   
    //getTitles(x => {
    //    titles(x)
    //});
    
    return {
        currentComponent,    
        menuElements,
        changeContent,
        isActive,
        titles
        //selectedComponent

    };


});