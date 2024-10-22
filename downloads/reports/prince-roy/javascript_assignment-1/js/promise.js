let audioUrl = '';

async function getRandomWord() {
  try {
    const response = await fetch(getWordApi());
    const { word } = await response.json();

    if (!response.ok)
      throw new Error(`${response.status} Error occured while getting random word.`);

    updateDOM(word);

    try {
      const dictionaryResponse = await fetch(`${getDictionaryApiUrl()}/${word}`);
      const dictionaryData = await dictionaryResponse.json();

      if (!dictionaryResponse.ok)
        throw new Error(
          `${response.status} Opps! The word is not registered in the dictionary. Try some other word.`
        );

      const { meanings, phonetics } = dictionaryData[0];
      audioUrl = phonetics[0].audio;

      const meaningsArr = meanings.map((meaning) => ({
        [meaning.partOfSpeech]: meaning.definitions,
      }));

      updateDictionaryDetails(word, meaningsArr);
    } catch (error) {
      throw error;
    }
  } catch (error) {
    updateDOM();
    updateDictionaryDetails();
    alert(error);
  }
}

function updateDOM(word = '') {
  var para = document.getElementById('word');
  para.innerHTML = word;
}

function getMeaningsStr(meaningsArr) {
  let arr = [];
  return meaningsArr
    .map((meaning) => {
      arr = Object.entries(meaning);
      return `
      <p><span class='font-weight-bold'>${arr[0][0]}:</span> 
      ${arr[0][1].map((val) => `<p>${val.definition}</p>`).join('')}
      </p>
      `;
    })
    .join('');
}

function getExamples(meaningsArr) {
  let arr = [];
  return meaningsArr
    .map((meaning) => {
      arr = Object.entries(meaning);
      console.log(arr[0][1]);
      return `
      <p><span class='font-weight-bold'>${arr[0][1].length === 0 ? '' : arr[0][0]}:</span> 
      ${arr[0][1].map((val) => `<p>${val.example ? val.example : ''}</p>`).join('')}
      </p>
      `;
    })
    .join('');
}

function updateDictionaryDetails(word = '', meaningsArr = []) {
  // Write your code here
  const wordDetails = document.querySelector('#word-details');

  const btnAudio = new Audio(audioUrl);

  wordDetails.innerHTML = '';
  wordDetails.innerHTML = `
                <td id="word">${word}</td>
                <td id="pronunciation">
                  ${audioUrl && `<img class='audioImg' src='volume-high-solid.svg' alt='' />`}
                </td>
                <td id="meaning">${getMeaningsStr(meaningsArr)}</td>
                <td id="example">${getExamples(meaningsArr)}</td>
              `;

  const audioBtn = document.querySelector('.audioImg');
  audioBtn.addEventListener('click', () => {
    btnAudio.play();
  });
}
