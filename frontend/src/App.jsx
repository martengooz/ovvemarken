import React from 'react';
import ReactDOM from 'react-dom';
import './App.css';
import axios from 'axios';

function getPatch(id) {
  axios.get('https://localhost:5001/api/patch/' + id)
  .then(function (response) {
    console.log(response.data)
    return(response.data);
  })
  .catch(function (error) {
    console.log(error);
  })
}

function App() {  
  let data = getPatch(1);
  console.log(data)
  return (
    <div className="App">
      <p>Patch: { data }</p>
    </div>
  );
}

export default App;
ReactDOM.render(<App />, document.getElementById('root'));
