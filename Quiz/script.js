function disableOptions(questionName) {
    let options = document.getElementsByName(questionName);
    options.forEach(option => {
        if(!option.checked) {
            option.disabled = true;
        }
    });
}
function playSound(){
    let clicksound = document.getElementById('selecionasom');
    clicksound.play();

}
function submitQuiz(){
    let questaocorreta = {
        q1: "B",
        q2: "C",
        q3: "B",
        q4: "C",
        q5: "C",
        q6: "C",
        q7: "C",
        q8: "B",
        q9: "C",
        q10: "C",
    };

    let form = document.getElementById('quiz');
    let score = 0;
    for (let key in questaocorreta) {
        let userAnswer = form.elements[key].value;
        if (userAnswer === questaocorreta[key]){
            score++
        }
    }
    let result = document.getElementById('result');
    result.innerHTML = `Você acertou ${score} de 10 perguntas. `;
    
    if (score === 2){
        let somvitoria = document.getElementById('venceusom');
        somvitoria.play();
    } else if (score !== 10) {
        let somperder = document.getElementById('perdeusom')
        somperder.play();
    }
}