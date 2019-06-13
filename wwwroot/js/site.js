// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
"use strict"
//OnLoad Animation
window.onload = function(){
    //javascript off catch.
    let msg  = "";
     function updateMsg() {
         let el = document.getElementById("message");
         el.textContent = msg; 
     }
     
     updateMsg();

//Index Page Scripts
     myTimer();

     function myTimer() {
          let visited = false;
         visited = sessionStorage["visited"];
         if (!visited) {
             sessionStorage["visited"] = true;

             $(document).ready(function() {
                 //Index Intro Animation
                 $('#10').fadeIn('slow');
                 $('#11').fadeTo(4000, 1);
                 $('#12').delay(3000).fadeTo(4000, 1);
                 $('#13').delay(6000).fadeTo(4000, 1);
                 $('#10').delay(4000).fadeTo(4000, 0);
                 $('#16').delay(10000).fadeTo(2000, 1);
                 $('#17').delay(1000).fadeTo(4000, 1);
                 $('#17').delay(5000).fadeTo(2000, 0);

                 //Scroll to Index>About-Me
                 $('html,body').delay(12000).animate({
                     scrollTop: $('#gotoAbout').offset().top
                 }, 2000);

                 //Sliding Function
                 $(".sliding-link").click(function(e) {
                     e.preventDefault();
                     var aid = $(this).attr("href");
                     $('html,body').animate({
                         scrollTop: $(aid).offset().top
                     }, 2000);
                 });
             });
         } else {
             $(document).ready(function() {
                 $('#11').show();
                 $('#12').show();
                 $('#13').show();
                 $('#10').show();
                 $('#16').show();

                 //Sliding Function
                 $(".sliding-link").click(function(e) {
                     e.preventDefault();
                     var aid = $(this).attr("href");
                     $('html,body').animate({
                         scrollTop: $(aid).offset().top
                     }, 2000);
                 });
             });
         }
     }

//  CV Page Scroll
     $(document).ready(function() {
         //Sliding Function
         $(".sliding-link").click(function(e) {
             e.preventDefault();
             var aid = $(this).attr("href");
             $('html,body').animate({
                 scrollTop: $(aid).offset().top
             }, 500);
         });
     });

// Examples
     //Example Page scroll
     $(document).ready(function() {
         //Sliding Function
         $(".sliding-links").click(function(e) {
             e.preventDefault();
             var aid = $(this).attr("href");
             $('html,body').animate({
                 scrollTop: $(aid).offset().top
             }, 2500);
         });
     });

//Transitions to Examples

     $(document).ready(function (){
         $("#button1").click(function (){
            console.log("O-View2");
             $('html, body').animate({
                 scrollTop: $("#OceanView").offset().top
             }, 2000);
         });
     });
     
     $(document).ready(function (){
         $("#button2").click(function (){
             console.log("O-View1");
             $('html, body').animate({
                 scrollTop: $("#OceanView").offset().top
             }, 2000);
         });
     });
     
     $(document).ready(function (){
         $("#button3").click(function (){
            console.log("C_Diary");
             $('html, body').animate({
                 scrollTop: $("#ChildDiary").offset().top
             }, 2000);
         });
     });
     
     $(document).ready(function (){
         $("#button4").click(function (){
            console.log("DOTNet");
             $('html, body').animate({
                 scrollTop: $("#dotNet3Tier").offset().top
             }, 2000);
         });
     });
     
     $(document).ready(function (){
         $("#button5").click(function (){
             $('html, body').animate({
                 scrollTop: $("#ChildDiaryCurriculumReport").offset().top
             }, 2000);
         });
     });

 $(document).ready(function (){
         $("#button6").click(function (){
             $('html, body').animate({
                 scrollTop: $("#AngularWebApp").offset().top
             }, 2000);
         });
     });

};