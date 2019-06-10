var el=document.getElementsByClassName('orderInfo');
var ael=document.getElementById('offer');
ael.addEventListener('click', showOrderInfo, false);


function showOrderInfo(){

    el[0].style.opacity="0";
    el[0].style.transition="all 0.4s"
    el[0].style.display="block";
    el[0].style.overflow="visible";

    //console.log(el[0].style.transition);
    setTimeout(temp,100,el[0])
    
}
function temp(el){
    el.style.opacity="1";
}
