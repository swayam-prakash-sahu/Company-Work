let wordApiURL = '';
async function getRandomWord() {   
    const wordApiURL = getWordApi();
    const wordResponse = await fetch(wordApiURL);
    const wordData = await wordResponse.json();
    
    updateDOM(wordData.word);
    
    const dictionaryApiURL = getDictionaryApiUrl() + '/' + wordData.word;
    const dictionaryResponse = await fetch(dictionaryApiURL);
    const dictionaryData = await dictionaryResponse.json();
    
    const dictionaryInfo = dictionaryData[0];
    // const meaningLength = dictionaryInfo.meanings.length;
    let meaningsToPrint = [];
    let meaning = {};
    dictionaryInfo.meanings.map(item => {
      meaning['phonetic']=item.phonetic;
      meaning['partOfSpeech'] = item.partOfSpeech;
      meaning['definitions'] = item.definitions;
      meaning['example'] = item.example;
      meaningsToPrint.push(meaning);
});
  
updateDictionaryDetails(dictionaryInfo.word, meaningsToPrint);
} 

  

function updateDOM(word) {
    var para = document.getElementById('word');
    para.innerHTML= word;
  }
  
  function updateDictionaryDetails(word, meanings) {
    const tableBody = document.getElementById('word-details');
  
    meanings.forEach(meaning => {
      const row = tableBody.insertRow();
      row.innerHTML = `
        <td>${word}</td>
        <td>${meaning.phonetic || ''}</td>
        <td>${meaning.partOfSpeech || ''}</td>
        <td>${meaning.definitions[0]?.definition || ''}</td>
        <td>${meaning.definitions[0]?.example || ''}</td>
      `;
    });
  }
  