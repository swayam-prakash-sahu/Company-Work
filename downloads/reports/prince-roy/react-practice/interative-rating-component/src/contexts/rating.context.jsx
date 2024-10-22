import { createContext, useState } from 'react';

export const RatingContext = createContext({
  ratingCount: 0,
  setRatingCount: () => {},
});

export const RatingProvider = ({ children }) => {
  const [ratingCount, setRatingCount] = useState(0);

  const value = { ratingCount, setRatingCount };

  return <RatingContext.Provider value={value}>{children}</RatingContext.Provider>;
};
