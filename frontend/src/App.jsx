import React, { useState, useEffect } from "react";
import "./App.css";

export default function App() {
  const [data, setData] = useState({});

  function getPatch(id) {
    fetch(`https://localhost:44394/api/patch/${id}`)
      .then((response) => response.json())
      .then((data) => {
        setData(data);
      })
      .catch(function (error) {
        console.log("Error: " + error);
      });
  }

  useEffect(() => {
    getPatch(1);
  }, []);

  return (
    <div className="App">
      <p>Patch: {data.id}</p>
    </div>
  );
}
