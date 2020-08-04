let prefijos = ["Tirano", "Tri"]
let sufijos = ["saurio", "dáctilo", "atops"]

function dinosaurize()
{
    const name = document.getElementById('name').value;
    var item = sufijos[Math.floor(Math.random() * sufijos.length)];
    const result = document.getElementById('result');
    result.innerHTML = name.toLowerCase() + item;
}