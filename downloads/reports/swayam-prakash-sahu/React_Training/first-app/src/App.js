import React, { useState } from 'react';
import './App.css'; // Importing CSS file for global styles
import ColorChanger from './ColorChanger';
import ColoredBox from './ColoredBox';

const App = () => {
 // const [boxColor, setBoxColor] = useState('red');
  const [pageColor, setPageColor] = useState('white');

  const handleColorChange = (color) => {
   // setBoxColor(color);
    setPageColor(color);
  };

  return (
    <div className="app-container" style={{ backgroundColor: pageColor }}>
      {/* <h1>Color Changing Box</h1> */}
      <ColorChanger onColorChange={handleColorChange} />
      {/* <ColoredBox color={boxColor} /> */}
    </div>
  );
};

export default App;
