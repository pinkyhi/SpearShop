function numInStr(str){
    let digit=['0','1','2','3','4','5','6','7','8','9'];
    let count=0;
    for(let i = 0; i< str.length ; i++){
        if(digit.indexOf(str[i])!=-1);
        count++;
    }
    return count;  
    
}

function validate(){
    var flag=true;
    if(document.getElementById("numerator").value<1){
        flag=false;
    }
    else {
        var xxx = document.getElementsByClassName("deliveryTypeRadio");
        for (i = 0; i < xxx.length;i++) {
            flag = flag || xxx[i].checked;
        }

        if (flag){

            if(!document.getElementById("deliveryDep").value){
                flag=false;
            }
            else{
                if(!document.getElementById("fio").value || document.getElementById("fio").value.length<10){
                    flag=false;
                }
                else{
                    var telPattern = /^[0-9+]{10,16}$/;
                    if(document.getElementById("phone").value.length==0||document.getElementById("phone").value.search(telPattern)!=0){
                    //if(!document.getElementById("phone").value && document.getElementById("phone").value.length<10 && !( numInStr(document.getElementById("phone").value)>=10) && (numInStr(document.getElementById("phone").value) - document.getElementById("phone").value.length>1)) {
                        flag=false;
                    }
                    else{
                        var pattern = /^[a-z0-9_-]+@[a-z0-9-]+\.[a-z]{2,6}$/i;
                        if(document.getElementById("mail").value.search(pattern)==0 && document.getElementById("mail").value.length!=0){
                        //if(document.getElementById("mail").value.lastIndexOf('@')>0 && document.getElementById("mail").value.lastIndexOf('.')>0 && (document.getElementById("mail").value.lastIndexOf('.')-document.getElementById("mail").value.lastIndexOf('@')>1) && document.getElementById("mail").value.length>4){
                            flag=true;
                        }
                        else{
                            flag=false;
                        }
                    }
                }   
            }
        }     
    }
    
    if(flag){
        valid();
    }
    else{
        invalid();
    }
}
function valid() {
    document.getElementById("zoneField").value = new Date().getTimezoneOffset();
    document.getElementsByClassName("orderInfo")[0].submit();
    alert("Ваш заказ принят!");
}
function invalid(){
    alert("Проверьте вашу форму!");
}

document.getElementById("fullSubmitButton").addEventListener("click", validate, false);