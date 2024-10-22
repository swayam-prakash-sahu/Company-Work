// SG comments I have added to understand the flow of the code 
// this two objects are declared below to store the api configurations.
let wordApiConfiguration = {};
let dictionaryApiConfiguration = {};
// IIFE 
(function() {
    fetch('../config/word-config.json') // initiating a fetch request to get configuration from config file
    .then(response => response.json()) // converts the fetched object into a json object 
    .then((result) => {
        wordApiConfiguration = result; // this assigns the json object retrived to worrdApiConfiguration
    });
// SG this function, calls itself after declaration 
    fetch('../config/dictionary-config.json') //similarly fetching for dictionary api
    .then(response => response.json()) // converting
    .then((result) => {
        dictionaryApiConfiguration = result; // assigning
    })
})();

function getWordApi()
{
    const wordApiUrl = wordApiConfiguration.wordApiUrl;
    // extracts the url property form wordApiConfiguration 
    const wordApiOptions = getApiOptions(wordApiConfiguration);
    // gets the parameters 
    return wordApiUrl+wordApiOptions;
    //this creates the full url
}

function getDictionaryApiUrl()
{
    return dictionaryApiConfiguration.dictionaryApi+dictionaryApiConfiguration.language;
    
}

function getApiOptions(word) {
    let apiOptions = `hasDictionaryDef=${word.hasDictionaryDef}`;
    apiOptions    += `&maxCorpusCount=${word.maxCorpusCount}`;
    apiOptions    += `&minDictionaryCount=${word.minDictionaryCount}`;
    apiOptions    += `&maxDictionaryCount=${word.maxDictionaryCount}`;
    apiOptions    += `&minLength=${word.minLength}`;
    apiOptions    += `&maxLength=${word.maxLength}`;
    apiOptions    += `&api_key=${word.wordApiKey}`;

    return apiOptions;
}