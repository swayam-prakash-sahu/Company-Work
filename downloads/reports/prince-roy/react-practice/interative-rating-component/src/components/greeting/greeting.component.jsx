import { useContext } from 'react';
import IllustrationThankYou from '../../assets/images/illustration-thank-you.svg';

import './greeting.styles.scss';
import { RatingContext } from '../../contexts/rating.context';

const Greeting = () => {
  const { ratingCount } = useContext(RatingContext);
  return (
    <div className='greeting-container'>
      <div className='illustration-container'>
        <img src={IllustrationThankYou} alt='' />
      </div>
      <span>You selected {ratingCount} out of 5</span>
      <h2>Thank you!</h2>
      <p>
        We appreciate you taking the time to give a rating. If you ever need more support, don't
        hesitate to get in touch!
      </p>
    </div>
  );
};

export default Greeting;
