import React, { useState, useEffect } from "react";
import Box from "@material-ui/core/Box";
import { makeStyles } from "@material-ui/core";

const useStyles = makeStyles((theme) => ({
  patch: {
    margin: "10px",
    position: "relative",
    "&:hover": {
      "& $patchInfo": {
        opacity: "0.8",
      },
    },
  },
  patchImage: {},
  patchInfo: {
    position: "absolute",
    top: "0",
    bottom: "0",
    left: "0",
    right: "0",
    height: "100%",
    width: "100%",
    opacity: "0",
    transition: ".5s ease",
    color: "#F7F6F7",
    backgroundColor: "#696969",
  },
  patchInfoNoImage: {
    position: "absolute",
    top: "0",
    bottom: "0",
    left: "0",
    right: "0",
    opacity: "1",
    transition: ".5s ease",
    color: "#475564",
    backgroundColor: "#F7F6F7",
  },
  patchInfoHeader: {
    margin: "0",
    padding: "10px 10px",
    textAlign: "center",
    color: "#F7F6F7",
  },
  patchInfoText: {
    padding: "0px 10px",
  },
}));

export default function GridPatch(props) {
  const textBackgroundColors = ["#133700", "#001337", "#420420"];
  const classes = useStyles();

  const { patch, i } = props;

  if (patch.imageLink) {
    return (
      <Box className={classes.patch}>
        <img
          className={classes.patchImage}
          height="200"
          src={`/assets/patchImages/${patch.imageLink}`}
        />
        <div className={classes.patchInfo}>
          <div
            height="10%"
            style={{
              backgroundColor:
                textBackgroundColors[i % textBackgroundColors.length],
            }}
          >
            <h3 className={classes.patchInfoHeader}>{patch.name}</h3>
          </div>
          <p className={classes.patchInfoText}>
            {patch.name} {patch.name} {patch.name}
          </p>
        </div>
      </Box>
    );
  } else {
    return (
      <Box height="200px" width="200px" className={classes.patch}>
        <div className={classes.patchInfoNoImage}>
          <div
            height="10%"
            style={{
              backgroundColor:
                textBackgroundColors[i % textBackgroundColors.length],
            }}
          >
            <h3 className={classes.patchInfoHeader}>{patch.name}</h3>
          </div>
          <p className={classes.patchInfoText}>
            {patch.name} {patch.name} {patch.name}
          </p>
        </div>
      </Box>
    );
  }
}

GridPatch.defaultProps = {
  data: {},
};
