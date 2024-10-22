import { useContext, useState } from 'react';
import './number-box.styles.scss';
import { RatingContext } from '../../contexts/rating.context';

const NumberBox = ({ val }) => {
  const [isClicked, setIsClicked] = useState(false);
  const [isActive, setIsActive] = useState(false);

  const { setRatingCount } = useContext(RatingContext);

  const handleNumberBtn = e => {
    setIsClicked(!isClicked);
    if (e.target.innerText > 1) console.log(e.target.previousElementSibling.classList[0]);
    console.log(val);
    setRatingCount(ratingCount => ratingCount + 1);
  };

  return (
    <>
      <button
        disabled={isActive}
        className={isClicked ? 'active' : 'btn-number'}
        onClick={handleNumberBtn}
      >
        {val + 1}
      </button>
    </>
  );
};

export default NumberBox;
