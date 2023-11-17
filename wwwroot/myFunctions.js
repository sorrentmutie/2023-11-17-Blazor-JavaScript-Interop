window.miaPrimaFunzione = function () {
    console.log("hello World");
}

window.somma = (a, b) => a + b;


window.miaTerzaFunzione = function () {
    DotNet.invokeMethodAsync('DemoBlazorInterop', 'TerzaFunzioneDotNet', 'Salvatore')
        .then(data => console.log(data));
}

window.sayHello = function (helloHelper) {
   helloHelper.invokeMethodAsync('SayHello')
          .then(data => console.log(data));
}