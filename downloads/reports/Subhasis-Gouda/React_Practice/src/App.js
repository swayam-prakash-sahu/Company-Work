import classes from './App.Module.css';
import { useState } from 'react';

const elements = [
  { number: 1, symbol: 'H', name: 'Hydrogen' },
  { number: 2, symbol: 'He', name: 'Helium' },
  { number: 3, symbol: 'Li', name: 'Lithium' },
  { number: 4, symbol: 'Be', name: 'Beryllium' },
  { number: 5, symbol: 'B', name: 'Boron' },
  { number: 6, symbol: 'C', name: 'Carbon' },
  { number: 7, symbol: 'N', name: 'Nitrogen' },
  { number: 8, symbol: 'O', name: 'Oxygen' },
  { number: 9, symbol: 'F', name: 'Fluorine' },
  { number: 10, symbol: 'Ne', name: 'Neon' },
  { number: 11, symbol: 'Na', name: 'Sodium' },
  { number: 12, symbol: 'Mg', name: 'Magnesium' },
  { number: 13, symbol: 'Al', name: 'Aluminum' },
  { number: 14, symbol: 'Si', name: 'Silicon' },
  { number: 15, symbol: 'P', name: 'Phosphorus' },
  { number: 16, symbol: 'S', name: 'Sulfur' },
  { number: 17, symbol: 'Cl', name: 'Chlorine' },
  { number: 18, symbol: 'Ar', name: 'Argon' },
  { number: 19, symbol: 'K', name: 'Potassium' },
  { number: 20, symbol: 'Ca', name: 'Calcium' }
];

const App = () => {

  const [selectedElement, setSelectedElement] = useState(null);
  return (
    <div className='box'>
        <h1 style={{marginLeft : '48%'}}>Periodic Table</h1>
        <div className="container">
          <div className="periodic-table">
            {elements.map((element) => (
              <div key={element.symbol} style={selectedElement==element?{ backgroundColor: '#021e3dfb',
              color: 'white'}:{}}
                className='element'
                onClick={() => setSelectedElement(element)}>
                {element.name}
              </div>
            ))}
          </div>
          <div className="selected-element">
          <h2>Description of the element</h2>
          {selectedElement? (
            <div>
              <h2>{selectedElement.name}</h2>
              <p>Symbol: {selectedElement.symbol}</p>
              <p>Atomic Number: {selectedElement.number}</p>
            </div>
            ):(<p>Not yet clicked on any elements!</p>)}

          </div>
        </div>
      </div>
    
  );
}

export default App;

