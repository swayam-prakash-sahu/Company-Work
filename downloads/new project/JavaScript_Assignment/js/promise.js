let wordApiURL = '';

// This function fetches a random word, its details, and updates the DOM accordingly.
async function getRandomWord() {
  try {
    // Fetch a random word from the API asynchronously
    wordApiURL = getWordApi();
    const wordResponse = await fetch(wordApiURL); // Fetching the random word data
    const wordData = await wordResponse.json(); 

    
    const dictionaryResponse = await fetch(`${getDictionaryApiUrl()}/${wordData.word}`);
    const dictionaryData = await dictionaryResponse.json(); 

    // Extract information from the dictionary data
    const { word, meanings } = dictionaryData[0];
    const meaningsArr = meanings.map((meaning) => ({
      [meaning.partOfSpeech]: meaning.definitions,
    }));

    // Update the DOM with the fetched word
    updateDOM(word);
    
    // Update the dictionary details section with the fetched meanings
    updateDictionaryDetails(word, meaningsArr);
  } catch (error) {
    // If any error occurs during the fetching or processing of data, display an alert
    showAlert('Oops! Something went wrong. Please try again later.');
    console.error(error); // Log the error to the console for debugging purposes
  }
}

// Function to display a custom alert message
function showAlert(message) {
  // Create a new element for the alert message
  const alertElement = document.createElement('div');
  alertElement.className = 'alert';
  alertElement.textContent = message;

  // Append the alert message to the body of the document
  document.body.appendChild(alertElement);

  // Remove the alert message after a certain duration (e.g., 5 seconds)
  setTimeout(() => {
    document.body.removeChild(alertElement);
  }, 5000); // 5000 milliseconds (5 seconds)
}

// Updates the DOM with the provided word
function updateDOM(word) {
  const para = document.getElementById('word');
  para.innerHTML = word;
}

// Constructs a string representation of meanings array to display in the dictionary details section
function getMeaningsStr(meaningsArr) {
  return meaningsArr
    .map((meaning) => {
      const entries = Object.entries(meaning);
      return `
      <p><span class='font-weight-bold'>${entries[0][0]}:</span> 
      ${entries[0][1].map((val) => `<p>${val.definition}</p>`).join('')}
      </p>
      `;
    })
    .join('');
}

// Updates the dictionary details section with the provided word and its meanings
function updateDictionaryDetails(word, meanings) {
  const wordDetails = document.querySelector('#word-details');

  // Clear existing content and update with new content
  wordDetails.innerHTML = `
    <td id="word">${word}</td>
    <td id="pronunciation"></td>
    <td id="meaning">${getMeaningsStr(meanings)}</td>
    <td id="example"></td>
  `;
}

// AJAX and async/await are implemented within the getRandomWord function.
// The fetch function is used for AJAX requests.
// Async/await is used to handle asynchronous operations cleanly.


  
