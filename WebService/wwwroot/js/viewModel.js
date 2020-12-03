define(['knockout'], (ko) => {
    let currentComponent = ko.observable("home");
    let menuElements = ["Home", "Movies"];
    let changeContent = element => {
        console.log(element);
        currentComponent(element.toLowerCase());

    }

    let isActive = element => {
        return element.toLowerCase() === currentComponent() ? "active" : ""
    }
    return {
        currentComponent,    
        menuElements,
        changeContent,
        isActive
    };
});