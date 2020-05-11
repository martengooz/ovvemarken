import React, { useState, useEffect } from "react";
import GridView from "./GridView.jsx";

export default function StartPage(props) {
  const [patches, setPatches] = useState([]);

  function searchPatches(searchQuery) {
    fetch(`https://localhost:44394/api/search`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(searchQuery),
    })
      .then((response) => response.json())
      .then((data) => {
        setPatches(data);
      })
      .catch(function (error) {
        console.log("Error: " + error);
      });
  }

  useEffect(() => {
    searchPatches(props.searchQuery);
  }, []);

  return <GridView patches={patches} />;
}

StartPage.defaultProps = {
  searchQuery: {},
};
