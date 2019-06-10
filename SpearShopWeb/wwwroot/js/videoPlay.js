function temp1(el,op){
    el.style.opacity=op;
}

function show() {
    var shadow = document.getElementById("shadow");
    shadow.style.display = "block";
    setTimeout(temp1, 150, shadow, 0.7);
    if (document.getElementById("vid") != null) {
        document.getElementById("vid").style.display = "block";
    }
}

function hide(){
    var shadow=document.getElementById("shadow");
    
    setTimeout(temp1,50,shadow,0);
    setTimeout(function(){shadow.style.display="none";},400);
    if (document.getElementById("vid") != null) {
        document.getElementById("vid").style.display = "none";
    }
}

document.getElementById("playButton").addEventListener("mousedown", show, true);

document.addEventListener('keydown', (event) => {
    if(event.keyCode==27){
       hide();
    }
    
  });
  document.addEventListener("mousedown", (event) => {
    
      if (event.target != document.getElementById("vid") && event.target != document.getElementById("playButton") && event.target != document.getElementsByTagName("i")[0]) {
          if (document.getElementById("vid") != null) {
              document.getElementById("vid").pause();
          }
          hide();
      }
    
  });
