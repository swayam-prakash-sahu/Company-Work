import React, { useState } from 'react';

const ColoredBox = ({ color }) => {
  return (
    <div className="colored-box" style={{ backgroundColor: color }}>
      Colored Box
    </div>
  );
};

const App = () => {
  // State to manage the color of the box
  const [boxColor, setBoxColor] = useState('red');

  // Function to handle color change
  const handleColorChange = (color) => {
    setBoxColor(color);
  };

  return (
    <div className="button-container">
      <h1>Color Changing Box</h1>
      <ColoredBox color={boxColor} />
      <button onClick={() => handleColorChange('red')}>Red</button>
      <button onClick={() => handleColorChange('blue')}>Blue</button>
      <button onClick={() => handleColorChange('green')}>Green</button>
    </div>
  );
};

export default App;

