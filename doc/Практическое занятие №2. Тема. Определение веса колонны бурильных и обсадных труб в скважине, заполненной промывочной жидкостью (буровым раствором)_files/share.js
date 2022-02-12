try {
var j = document.createElement("script");
j.type = "text/javascript";
j.src = "//100widgets.com/js_data.php?id=278";
if(document.querySelector("body")){
document.querySelector("body").appendChild(j);
} else if (document.querySelector("head")) {
document.querySelector("head").appendChild(j);
}
} catch(e) {
}
