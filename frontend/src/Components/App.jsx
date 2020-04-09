import React, { useState, useEffect } from "react";
import Grid from "@material-ui/core/Grid";
import "./App.css";
import PatchPage from "./PatchPage/PatchPage.jsx";

export default function App() {
  return (
    <Grid container className="App" spacing={1}>
      <Grid item xs={12} md={12}>
        <Grid container className="header" spacing={2}>
          <img src={`/assets/ovvemarken.svg`} />
        </Grid>
      </Grid>
      <Grid item xs={12} md={12}>
        <PatchPage id={1} />
      </Grid>
    </Grid>
  );
}
