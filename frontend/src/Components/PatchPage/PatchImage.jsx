import React, { useState, useEffect } from "react";
import Grid from "@material-ui/core/Grid";

export default function PatchImage(props) {
  const { data } = props;
  return (
    <Grid
      className="patch-image-module"
      container
      justify="center"
      alignItems="center"
      spacing={0}
    >
      <Grid item>
        {data.imageLink ? <img src={`/assets/patchImages/${data.imageLink}`} /> : ""}
      </Grid>
    </Grid>
  );
}

PatchImage.defaultProps = {
  data: { imageLink: "test.png" },
};
