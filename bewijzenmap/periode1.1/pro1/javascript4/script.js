//declaraties Cluster 1
let studiepuntenHaalbaarCluster1 = document.getElementById("studiepuntenHaalbaarCluster1").innerHTML;
let studiepuntenBehaaldCluster1 = document.getElementById("studiepuntenBehaaldCluster1");
let PROJ = document.getElementById('PROJ');
let TPR = document.getElementById('TPR');
let gemiddeldeCluster1 = document.getElementById('gemiddeldeCluster1');
//function Cluster 1
PROJ.addEventListener('input', berekenGemiddeldeCluster1);
TPR.addEventListener('input', berekenGemiddeldeCluster1);
function berekenGemiddeldeCluster1()
{
    let gemiddelde = (parseFloat(PROJ.value) + parseFloat(TPR.value))/2;
    gemiddeldeCluster1.innerHTML = gemiddelde;
    if (gemiddelde >= 5.5){
        studiepuntenBehaaldCluster1.innerHTML = studiepuntenHaalbaarCluster1;
    }
    else {studiepuntenBehaaldCluster1.innerHTML = 0;}
    berekenTotaalSP();
}

//declaraties Cluster 2
let studiepuntenHaalbaarCluster2 = document.getElementById("studiepuntenHaalbaarCluster2").innerHTML;
let studiepuntenBehaaldCluster2 = document.getElementById("studiepuntenBehaaldCluster2");
let PRO1 = document.getElementById('PRO1');
let PRO2 = document.getElementById('PRO2');
let gemiddeldeCluster2 = document.getElementById('gemiddeldeCluster2');
//function Cluster 2
PRO1.addEventListener('input', berekenGemiddeldeCluster2);
PRO2.addEventListener('input', berekenGemiddeldeCluster2);
function berekenGemiddeldeCluster2() 
{
    let gemiddelde = (parseFloat(PRO1.value) + parseFloat(PRO2.value))/2;
    gemiddeldeCluster2.innerHTML = gemiddelde;
    if (gemiddelde >= 5.5){
        studiepuntenBehaaldCluster2.innerHTML = studiepuntenHaalbaarCluster2;
    }
    else {studiepuntenBehaaldCluster2.innerHTML = 0; }
    berekenTotaalSP();
}

//declaraties Cluster 3
let studiepuntenHaalbaarCluster3 = document.getElementById("studiepuntenHaalbaarCluster3").innerHTML;
let studiepuntenBehaaldCluster3 = document.getElementById("studiepuntenBehaaldCluster3");
let SLB = document.getElementById('SLB');
let WVO = document.getElementById('WVO');
let gemiddeldeCluster3 = document.getElementById('gemiddeldeCluster3');
//function Cluster 3
SLB.addEventListener('input', berekenGemiddeldeCluster3);
WVO.addEventListener('input', berekenGemiddeldeCluster3);
function berekenGemiddeldeCluster3() 
{
    let gemiddelde = (parseFloat(SLB.value) + parseFloat(WVO.value))/2;
    gemiddeldeCluster3.innerHTML = gemiddelde;
    if (gemiddelde >= 5.5){
        studiepuntenBehaaldCluster3.innerHTML= studiepuntenHaalbaarCluster3;
    }
    else { studiepuntenBehaaldCluster3.innerHTML = 0; }
    berekenTotaalSP(); 
}

//declaraties Cluster 4
let studiepuntenHaalbaarCluster4 = document.getElementById("studiepuntenHaalbaarCluster4").innerHTML;
let studiepuntenBehaaldCluster4 = document.getElementById("studiepuntenBehaaldCluster4");
let ENG = document.getElementById('ENG');
let NED = document.getElementById('NED');
let REK = document.getElementById('REK');
let gemiddeldeCluster4 = document.getElementById('gemiddeldeCluster4');
//function Cluster 4
ENG.addEventListener('input', berekenGemiddeldeCluster4);
NED.addEventListener('input', berekenGemiddeldeCluster4);
REK.addEventListener('input', berekenGemiddeldeCluster4);
function berekenGemiddeldeCluster4() 
{
    let gemiddelde = (parseFloat(ENG.value) + parseFloat(REK.value) + parseFloat(NED.value))/3;
    gemiddeldeCluster4.innerHTML = gemiddelde; 
    if (gemiddelde >= 5.5){
        studiepuntenBehaaldCluster4.innerHTML = studiepuntenHaalbaarCluster4;
    }
    else { studiepuntenBehaaldCluster4.innerHTML = 0; }
    berekenTotaalSP(); 
}

//declaraties Cluster 5
let studiepuntenHaalbaarCluster5 = document.getElementById("studiepuntenHaalbaarCluster5").innerHTML;
let studiepuntenBehaaldCluster5 = document.getElementById("studiepuntenBehaaldCluster5");
let DIFF = document.getElementById('DIFF');
let gemiddeldeCluster5 = document.getElementById('gemiddeldeCluster5');
//function Cluster 5
DIFF.addEventListener('input', berekenGemiddeldeCluster5);
function berekenGemiddeldeCluster5() 
{
    let gemiddelde = (parseFloat(DIFF.value))/1;
    gemiddeldeCluster5.innerHTML = gemiddelde; 
    if (gemiddelde >= 5.5){
        studiepuntenBehaaldCluster5.innerHTML = studiepuntenHaalbaarCluster5;
    }
    else { studiepuntenBehaaldCluster.innerHTML = 0; }
    berekenTotaalSP(); 
}


//bereken totaal aantal studiepunten
let totaalSP = document.getElementById('totaalSP');
function berekenTotaalSP()
{
    let studiepuntenTotaal = parseFloat(studiepuntenBehaaldCluster1.innerHTML)+
    parseFloat(studiepuntenBehaaldCluster2.innerHTML) +
    parseFloat(studiepuntenBehaaldCluster3.innerHTML) +
    parseFloat(studiepuntenBehaaldCluster4.innerHTML) +
    parseFloat(studiepuntenBehaaldCluster5.innerHTML);
    totaalSP.innerHTML = studiepuntenTotaal;
}
