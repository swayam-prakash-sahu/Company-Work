import React, { useState } from 'react';
import ColoredBox from './ColoredBox'; // Import ColoredBox component

const ColorChanger = ({ onColorChange }) => {
  const [backgroundColor, setBackgroundColor] = useState('white'); 

  const changeColor = () => {
    const colors = ['red', 'blue', 'green', 'yellow', 'orange']; 
    const randomIndex = Math.floor(Math.random() * colors.length); 
    setBackgroundColor(colors[randomIndex]); 
    onColorChange(colors[randomIndex]); // Call onColorChange function with the new color
  };

  return (
    <>
      <ColoredBox color={backgroundColor} />
      <h1>Hello, change my background color!</h1>
      <button onClick={changeColor}>Change Color</button>
    </>
  );
};

export default ColorChanger;


