__author__ = 'root'

import numpy as np
from enthought.mayavi import mlab

x, y = np.ogrid[0:3000:10j, 9:12:20j]
z = np.exp((8700 * 9.3 + x * y) / (8700 + x))
pl = mlab.surf(x, y, z, warp_scale=2)
mlab.axes(xlabel='x', ylabel='y', zlabel='z')
mlab.outline(pl)
mlab.show()
