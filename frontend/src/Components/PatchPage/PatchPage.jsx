import React, { useState, useEffect } from "react";
import Grid from "@material-ui/core/Grid";
import PatchInfo from "./PatchInfo.jsx";
import PatchImage from "./PatchImage.jsx";

export default function PatchPage(props) {
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
    if (props.id !== 0) {
      getPatch(props.id);
    }
  }, []);

  if (data) {
    return (
      <Grid container className="root">
        <Grid item md={2} />
        <Grid item xs={12} md={8}>
          <Grid container className="main-content" spacing={0}>
            <Grid item xs={12} md={6}>
              <PatchImage data={data} />
            </Grid>
            <Grid item xs={12} md={6}>
              <PatchInfo data={data} />
            </Grid>
          </Grid>
        </Grid>
        <Grid item md={2} />
      </Grid>
    );
  } else {
    return <Grid container className="root" />;
  }
}

PatchPage.defaultProps = {
  id: 0,
};
