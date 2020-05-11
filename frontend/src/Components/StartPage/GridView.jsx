import React, { useState, useEffect } from "react";
import Box from "@material-ui/core/Box";
import { makeStyles } from "@material-ui/core";
import GridPatch from "./GridPatch.jsx";

const useStyles = makeStyles((theme) => ({
  grid: {
    justifyContent: "space-between",
    "&::after": {
      content: '""',
      flex: "auto",
    },
  },
}));

export default function GridView(props) {
  const classes = useStyles();
  const [patches, setPatches] = useState(props.patches);
  const [grid, setGrid] = useState([]);

  function renderGrid() {
    const grid = [];
    patches.forEach((patch, i) => {
      grid.push(<GridPatch key={patch.id} patch={patch} i={i} />);
    });
    setGrid(grid);
  }

  useEffect(() => {
    setPatches(props.patches);
  }, [props.patches]);

  useEffect(() => {
    renderGrid();
  }, [patches]);

  return (
    <Box className={classes.grid} flexWrap="wrap" display="flex">
      {grid}
    </Box>
  );
}

GridView.defaultProps = {
  data: {},
};
