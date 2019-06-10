function showSub(){
    if(this.children.length>1){
        this.children[1].style.transition="opacity 0.4s"
        this.children[1].style.height= "auto";
        this.children[1].style.opacity="1";
        this.children[1].style.overflow="visible";
    } 
    else{
        return false;
    }
}

function hideSub(){
    if(this.children.length>1){
        this.children[1].style.transition="opacity 0.4s"
        this.children[1].style.overflow="hidden";
        this.children[1].style.opacity="0";
        setTimeout(heightZero,400,this.children[1]);
       



    } 
    else{
        return false;
    }

    function heightZero(element){
        element.style.height=0;
    }


}




var el=document.getElementsByClassName('menu-item');
for(var i=0;i<el.length;i++){
    el[i].addEventListener('mouseenter', showSub, false);
    el[i].addEventListener('mouseleave', hideSub, false);
}