// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
async function getUsers(__RequestVerificationToken) {
    const url = "https://whispering-tundra-91467.herokuapp.com/api/users/nicolas.genest@codeboxx.biz/";
fetch(url)
 .then(
     response => console.log(response)// .json(), etc.
     // same as function(response) {return response.text();}
 );
   
     

 } 
 