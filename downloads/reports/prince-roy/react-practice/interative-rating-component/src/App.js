import { useState } from 'react';

import Greeting from './components/greeting/greeting.component';
import NumberBox from './components/number-box/number-box.component';
import Icon from './assets/images/icon-star.svg';

import './App.scss';

const numbers = [1, 2, 3, 4, 5];

function App() {
  const [isSubmitted, setIsSubmitted] = useState(false);
  const [activeIndex, setActiveIndex] = useState(0);

  const handleSubmitBtn = () => {
    setIsSubmitted(!isSubmitted);
  };

  return (
    <main className='App'>
      <h1>Interactive Card Component</h1>
      {isSubmitted ? (
        <Greeting />
      ) : (
        <div className='card-container'>
          <div className='icon-container'>
            <img src={Icon} alt='' />
          </div>
          <h2>How did we do?</h2>
          <p>
            Please let us know how we did with your support request. All feedback is appreciated to
            help us improve our offering!
          </p>

          <div className='number-box-container'>
            {[...Array(5)].map((_, i) => (
              <NumberBox key={i} val={i} />
            ))}
          </div>

          <button onClick={handleSubmitBtn} type='submit' className='btn-submit'>
            SUBMIT
          </button>
        </div>
      )}
    </main>
  );
}

export default App;
