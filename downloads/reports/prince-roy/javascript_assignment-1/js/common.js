let wordApiConfiguration = {};
let dictionaryApiConfiguration = {};

async function init() {
  try {
    let response = await fetch('config/word-config.json');
    wordApiConfiguration = await response.json();

    if (!response.ok) throw new Error(`${response.status} Opps! Word config not found.`);

    response = await fetch('config/dictionary-config.json');
    dictionaryApiConfiguration = await response.json();

    if (!response.ok) throw new Error(`${response.status} Opps! Dictionary config not found.`);
  } catch (error) {
    alert(`${error}`);
  }
}

init();

function getWordApi() {
  const { wordApiUrl } = wordApiConfiguration;
  const wordApiOptions = getApiOptions(wordApiConfiguration);

  return wordApiUrl + wordApiOptions;
}

function getDictionaryApiUrl() {
  const { dictionaryApi, language } = dictionaryApiConfiguration;
  return dictionaryApi + language;
}

function getApiOptions(word) {
  const {
    hasDictionaryDef,
    maxCorpusCount,
    minDictionaryCount,
    maxDictionaryCount,
    minLength,
    maxLength,
    wordApiKey,
  } = word;
  return `hasDictionaryDef=${hasDictionaryDef}&maxCorpusCount=${maxCorpusCount}&minDictionaryCount=${minDictionaryCount}&maxDictionaryCount=${maxDictionaryCount}&minLength=${minLength}&maxLength=${maxLength}&api_key=${wordApiKey}`;
}
